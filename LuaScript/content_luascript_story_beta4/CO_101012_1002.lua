-- このluaスクリプトは、CO_101012_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",155,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera003 = SetTemplate("Actor003",95,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
load_image("201010190","content_still_20101019_image","201010190_StillImage")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, {0.6, 0.5, 0.7, 0.5} , 1)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0058")
-- ▲直接出力

	--★★ノワール★★:…ふぅ。こんなもんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力

	--★★ディナタン★★:こっちも終わったよ。これでひと段落だね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020003")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0002")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:ふたりともお疲れ様<br>おかげで助かったわ。ありがとう
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ベッド、だいぶ空いたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:ええ。あのコンサートのあと<br>患者たちがみるみる元気になっていってね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020006")


	--★★イゾルデ★★:ディナタンの歌に応えるためにも<br>今度は自分たちが頑張ると張り切っていたわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020007")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:まだ入院している患者たちも表情が明るくなった<br>全部、あなたのおかげよ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020008")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:イゾルデさん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_10020011","CO_101012_10020012","CO_101012_10020013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あの日の歌声は、特に良かったもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020015")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンの強い想いが感じられたからかな<br>俺も元気になったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020016")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:お前はいつも元気じゃないの
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020017")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:確かに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020018")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:え、そういう反応…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ふふ。冗談<br>ありがと、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:特に歌詞が良かったな<br>胸に響くっていうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020022")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:わかるなぁ<br>やっぱりマァルの文才はすごいよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020023")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:それもあるけど、みんなのことを想う<br>ディナタンの気持ちが歌詞に込められてて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020024")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それがすごくよかったと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020025")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:そ、そんなにまっすぐ褒められると<br>なんか照れちゃうなぁ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020027")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:特に曲が良かったよな<br>心が洗われるっていうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020029")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:トリスタンが作った曲だもの、当然ね<br>彼も感謝していたわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020030")

	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:あなたたちのおかげで竪琴も直せたし<br>いい曲を作ることができたって
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020031")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:私も同じ気持ちよ<br>…ありがとう、ディナタン
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020032")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:イゾルデさん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020033")

	goto Block1end

::Block1end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:それじゃ、私は他の患者の様子を診てくるわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_10020035")

-- ▼直接出力
 setup_small_camera_start(Camera007)
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
turn_chara(Actor001,125,0.2)
turn_chara(Actor002,-100,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
--フェードイン
setup_small_camera_start(RndCamera090)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0010")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…よかった<br>みんなが元気になってくれて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンが頑張ったからだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020039")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:言ったろ？ディナタンの歌は<br>皆を元気にするって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020040")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん…でも兄さんが応援してくれなきゃ<br>きっと私、なにもできなかった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020041")


	--★★ディナタン★★:マァルに作詞してもらったり<br>トリスタンさんに曲をお願いしたり…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020042")


	--★★ディナタン★★:兄さんがいなかったら、<br>こんなに上手くいかなかったよ、きっと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなことないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020044")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0040")
-- ▲直接出力

	--★★ディナタン★★:ううん、そうなの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020045")


	--★★ディナタン★★:…私、ひとりじゃ勇気を出せなかったと思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020046")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ディナタン★★:昔からそう…兄さんはいつも<br>臆病な私の手を引っ張ってくれる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020047")


	--★★ディナタン★★:どんなに辛くて、逃げ出したいってときも<br>兄さんがいてくれたから――…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020048")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020049")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ありがとう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020051")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:きゅ、急に改まってなんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020052")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力

	--★★ディナタン★★:改まりたい気分なんです～
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020053")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:この学園に来て大変なこともたくさんあったけど<br>兄さんがいるから、頑張ってこれた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020054")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ディナタン★★:でもこれからは…それだけじゃ駄目だなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020055")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:駄目って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020056")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:みんなに負けてられない<br>私も頑張らなきゃって思ったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020057")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:これからは引っ張ってもらうだけじゃなくて<br>私も兄さんを引っ張れるように頑張りたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020058")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ディナタン★★:兄さんに頼ってばかりじゃ<br>キラーズとして情けないもん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020059")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020060")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いつの間にか<br>ずいぶんと立派になったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_10020061")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:自慢の妹でいたいからね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_10020062")

-- ▼直接出力
CloseTalkWindow()
show_image("201010190", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 
set_scale_image(0.9,0.9) 
wait_time(1.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんの力になれるように、<br>私、もっと頑張るから。だから…
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","CO_101012_10020063")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0011")
-- ▲直接出力

	--★★ディナタン★★:これからもよろしくね。兄さんっ！
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","CO_101012_10020065")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010190","content_still_20101019_image","201010190_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
