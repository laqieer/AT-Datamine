-- このluaスクリプトは、MA_01A110_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",-79,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, {1.0, 0.1, 0.3, 0.5} ,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:私、子供がいまして──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040002")

	open_select_window_tag(Actor001,"Normal","MA_01A110_040004","MA_01A110_040005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:た、大変なんだな…！？<br>いや、色々と事情があるのだろうけど…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_040007")

-- ▼直接出力
lookat_delay_weight(Actor002, {1.0, 0.1, 0.3, 0.5} ,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:えっ、あっ、いえ、すみません<br>言葉足らずで、違うんです、そうではないんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040008")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:子供がいるのはそうなんですが<br>私が産んだ子供ではなくてですね…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かから預かった子供？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_040011")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor002, {1.0, 0.1, 0.3, 0.5} ,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:わ、私の心が読めるんですか、先輩…！<br>完全に言葉足らずだったのに…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040012")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:せ、先輩と、お話していると<br>とても…安心してしまいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040013")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…ローマの、孤児たちなんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:ロンディニウムから逃げ延びた子らで…<br>虐殺が起きたあの日に保護、して…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040017")

	change_face(Actor002,"Normal")

	--★★エレイン★★:兄と私で…ログレスまで連れてきて<br>今は城下の孤児院にお世話になっています…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:その孤児たちが、ぐずってしまって<br>「ロンディニウムに帰りたい」と
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_040021","MA_01A110_040022")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:連れて行ってあげたいね<br>なんとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_040024")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…はい。そうなんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040025")

	change_face(Actor002,"Sad")

	--★★エレイン★★:脅威は掃討されても、危険がないわけじゃない…<br>ましてや民間人…子供たち、ですから…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040026")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩のお手をわずらわせる気は、ないんです<br>なにか方法があれば…伺えればとは、思ってて…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040027")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:危険だ、ログレスにいてもらおう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_040029")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…そう、ですよね<br>危険…ですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040030")

	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩は、現実的ですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040031")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
EntryWalk_2P(Actor003,Camera003,EntryData110071_01_06,CameraAssetBundleName110071_01,CameraPos110071_01_106,Actor004,CharaPos110071_01_007,CharaPos110071_01_107)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 lookat_delay_weight_reset(Actor001,0.1)
 lookat_delay_weight_reset(Actor002,0.1)
turn_chara(Actor001, 139, 0)
turn_chara(Actor002, -153, 0)
 --PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:ハナシは聞かせてもらったぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040033")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:ちょっとやめなさいってあんた<br>ほんとデリカシーとかないわけあんた
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_040034")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:えと、ガウェインさん…、と、ラグネルさん…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ロンディニウムは今<br>学園の騎士たちが持ち回りで巡回してんだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040036")


	--★★ガウェイン★★:普通、円卓の騎士にまで<br>その仕事がまわってくることはねえが
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040037")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺が友達に頼めば、ねじ込めるぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040038")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ラグネル★★:なんかバイトみたいだね
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_040040")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:すぐローマとぶつかんなきゃなんねえ<br>なるはやで──X日後でどーだ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040041")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力

	--★★エレイン★★:あ、あ、ありがとうございます…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_040043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:子供の涙の訴えは<br>断り切れないよねえ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_040044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:当然だろ！<br>それに…礼はノワールに言いな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、俺はなにもしてないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_040046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:俺とダチで、その子と知り合い<br>じゃねーとこの話にはなんなかった
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040047")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:お前がいるから<br>なんだぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_040048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
