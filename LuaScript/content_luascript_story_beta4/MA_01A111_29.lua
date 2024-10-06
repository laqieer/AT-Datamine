-- このluaスクリプトは、MA_01A111_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101090011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力

	--★★ラグネル★★:どっちが良いんだろうね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290002")


	--★★ラグネル★★:あの人に真っ向から挑むべきか<br>諦めずに説得を続けるべきか
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290003")

	open_select_window_tag(Actor001,"Normal","MA_01A111_290004","MA_01A111_290005","MA_01A111_290006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:真っ向から挑むべきだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_290008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:あの人に戦いを習ったあたしたちとしてはね<br>そうだよね、成果を見せるべきだと思う
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290009")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:弟子の成長を見たいとも思うだろうし<br>…でももし、まだ説得に応じてくれるなら──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:諦めずに説得を続けるべきだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_290012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:学園で先生してくれてたんだもんね<br>少なからずログレスに心残りはあって欲しい
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290013")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ラグネル★★:…あたしたちにも目を向けて欲しいよね<br>だけど、もうあの人の心が決まってるなら──
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290014")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_290016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ああ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","N","MA_01A111_290017")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:お前マジいい奴だよ、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290018")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:──ラグネルの好きにしていいぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290020")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:…あたしの？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290021")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ガウェイン★★:俺はお前の決定に賛成する！<br>全面的にな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290022")

-- ▼直接出力
setup_small_camera_start()
close_cutin()
-- ▲直接出力

	--★★ラグネル★★:ガウェインは…いいわけ？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:もちろん俺だってキメるぜ<br>ラグネルだけに決定の責任を負わせねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290024")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:だけどまあ、どうせキマってんだろ<br>答えは同じだろうって予想するぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:お前は俺だもんな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:………ぷっ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290028")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:…あたし<br>あんたに賛成するつもりだったんだよ？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:ずっと考えてたんだ<br>俺が憧れる英雄像について
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:あの人のコトバでさ<br>すげー印象的なの…思い出してさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290033")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルスの教え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_290034")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:「引き際をわきまえろ」<br>「ひとりで生き抜くすべを知れ」
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:…あったね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:俺らめっちゃ騒いだよな<br>「そんなんヒーローじゃねえ～！！」って
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そういうことなんだろうと思うぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺らがなろうとしてる憧れと<br>あの人がやろうとしてること…全然違ぇんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:それぞれの理想像があって<br>で、今もあの人は誰かの恩人なのかもしんねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290040")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:…そう思ったら<br>ワケわかんなくなっちまって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290042")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:けどやっぱお前らと笑ってメシ食うのが<br>一番面白ェなって最近よっく思ったからさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290043")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そういう騎士になんなきゃなんねえよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_290046")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:で、なんの話だっけ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_290048")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:早くメシ食いに帰ろうねってハナシ！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A111_290050")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101090011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
