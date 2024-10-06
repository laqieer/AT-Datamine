-- このluaスクリプトは、MA_01C112_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-129.44,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
turn_chara(Actor002,324.19,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悩む")
-- ▲直接出力

	--★★クラリス★★:うーん…なんか、空気が重いですねぇ…<br>せっかくのクリスマスなのに…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_310002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力

	--★★ガレス★★:本当だよね～
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310003")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Sad")

	--★★ガレス★★:食堂もクリスマス仕様にしてるのに<br>全然盛り上がんないし
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_311001")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:無理もないわね。王様に続き<br>学園復興の立役者まで消えたのだから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C112_310004")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガレス", "落胆")
-- ▲直接出力

	--★★ガレス★★:アバドンにいるかもしれない<br>ってことだけは、わかっているけど…
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310005")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:でも無策に飛び込んでいい状況ではないわ<br>…パーシヴァルのこともあるし
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C112_310006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:うん。そう…だね
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310007")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:で、その後始末はすべてキミが任されるわけだ<br>次の円卓会議までにキミは決断する
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310009")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★トリスタン★★:正直<br>クリスマスなんて気分じゃないよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガレス★★:ノワール…大丈夫か～？
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…え？あぁ、うん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_310013")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ねぇ、キミさ<br>あんまりひとりで抱え込まないでよ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★トリスタン★★:キミの頭で考えられることなんて<br>どうせタカが知れてるんだから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_310016","MA_01C112_310017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0.08, 0.4, 0.5,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.22)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、気を付けるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_310019")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…そ。ならその辛気臭い顔やめてよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310020")

	change_face(Actor005,"Normal")

	--★★ガレス★★:トリスタン、素直じゃないぞ～
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0, 0.5, 0.2,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.22)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ありがとう<br>心配してくれてるんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_310023")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…あのさ、そういうの<br>わざわざ言わないものだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310024")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:あら、よかったじゃない<br>ちゃんと真意が伝わって
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C112_310025")

	goto Block1end

::Block1end::
-- ▼直接出力
lookat_weight_default(Actor001)
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ガレス★★:でもトリスタンの言うことも一理あるぞ<br>とりあえず今は、できることをしよう！
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310027")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:できることというと…<br>クリスマスを楽しむ、とかでしょうか？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_310028")

-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガレス★★:みんなに楽しんでもらえるように<br>盛り上げるとか♪
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C112_310029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:それはなかなか難しそうだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_310030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
