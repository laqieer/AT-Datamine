-- このluaスクリプトは、CO_101014_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110181_01","110181_01_h")
Include("content_adv_advsmall_110181_01","Template110181_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",15,CharaPos110181_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_003)
	Camera002 = SetTemplate("Actor002",180,CharaPos110181_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_006)
	Camera003 = SetTemplate("Actor003",-100,CharaPos110181_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_004)
	InitializeTemplateRandomCamera110181_01()
	InitializeTemplate110181_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("103050120", "content_still_10305012_image", "103050120_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110181)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:…はないか。だけど…だからあっちには、ボクが…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010002")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0006_1")
-- ▲直接出力

	--★★ノワール★★:トリスタン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:キミか<br>…なんの用？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力

	--★★ノワール★★:え？いや、別に特に用事があるわけじゃないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010007")


	--★★ノワール★★:なんか難しい顔してたしどうしたのかと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なんか困ったことでもあるのか？よかったら俺、力になるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010009")

-- ▼直接出力
CloseTalkWindow() 
wait_time(0.1)
show_image("103050120", 0.0, 0.0, 0.1 ,true,false)
-- ▲直接出力
-- ▼直接出力
wait_time(1)
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力

	--★★トリスタン★★:嫌いなんだよね、握手
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
hide_image(0.2)
-- ▲直接出力

	--★★トリスタン★★:仲良くなったという意識の一方的な押し付けじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010012")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0002")
-- ▲直接出力

	--★★トリスタン★★:あとさ、頼んでもないのに<br>いちいち声かけるのやめてくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:ボクはキミと違って暇じゃないから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010014")

	open_select_window_tag(Actor001,"Normal","CO_101014_01010016","CO_101014_01010017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010019")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:別に、謝る必要はないけど…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:まあ、わかったならそれでいいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺だって暇なわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:あ、そうそれは失礼
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010025")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:でも、だったらなおさらこんなところで油売ってる場合じゃないんじゃない？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010026")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0006")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:それじゃ、ボクはこれで
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01010028")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1.0)
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,140,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、おい！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010029")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
change_face(Actor001,"Normal")
setup_small_camera_start(RndCamera008)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:行っちゃった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010031")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData110181_01_04,CameraAssetBundleName110181_01,CameraPos110181_01_104)
turn(Actor001,-0.78,100,1.301,0)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:よー、ノワール！<br>なにしてんだ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインか<br>…いや、今トリスタンがいてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なんか困ってそうな気がしたから<br>俺でよければ力を貸すって言ったんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010035")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:「頼んでもないのに話しかけるな」って怒られちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010036")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:あー、トリスタンらしいな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺って避けられてんのかな？「キミの力なんか必要ない」とも言われたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010038")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:うーん…気にすることないと思うぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010039")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:あいつが誰かの力を借りてるところなんてほとんど見たことねーもん。イゾルデくらいか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:ノワールを特別避けてるとかそういうわけじゃねーと思う
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010041")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺だってしょっちゅううるさいとか邪魔とか言われてるぜ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_01010042")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは胸を張って言うことなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあでも、いわれてみれば確かに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010045")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:トリスタンがイゾルデ以外の人と仲良くしているところは想像つかないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01010046")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050120", "content_still_10305012_image", "103050120_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110181)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110181_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
