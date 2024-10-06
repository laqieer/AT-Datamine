-- このluaスクリプトは、AV_01_101037.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",30,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Laugh")

	--★★ラシア★★:ノワール<br>こんなところで、なにをしているんですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0001")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:警備の手伝いで市街の見回りをしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:警備の手伝いを…<br>それはお疲れさまです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0003")

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:あの…警備の手伝いって大変ですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0004")


	--★★ノワール★★:想定外のことが突然起こったりするから<br>判断力や何事にも動じない精神力が求められるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:でも<br>そんなこと聞いて、どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0006")


	--★★ラシア★★:少しでもヴェルナルスさ…先生の力になれるよう<br>私も強くなりたいんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0007")

	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:警備の手伝いくらいなら<br>今の私でもできるかなと思って…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0008")

	open_select_window_tag(Actor001,"Normal","AV_01_101037_0009","AV_01_101037_0010","AV_01_101037_0011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:「警備の手伝いくらいなら」<br>なんて考えかたじゃ、なにもうまくいかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:一歩一歩進んでいくっていう考えかたは<br>とてもいいことだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でも<br>最初の一歩を軽んじちゃダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:強くなるのに近道なんてない<br>最初の一歩から力強く踏み込んでいかないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0016")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:ノワール…！<br>ありがとうございます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0017")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:焦らず、いろんなことを学びながら<br>進んでいくようにします
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:人手不足って聞いてるし<br>ラシアにその気があるならいいんじゃないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0020")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:…そう、ですか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あとで俺から聞いておこうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0022")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:…いえ、大丈夫です<br>私、用事があるのでこれで失礼しますね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0023")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.1, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_active(Actor002)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（しまった…<br>もうちょっと親身に対応するべきだった…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101037_0024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:手伝いたいなんて言ったら<br>喜んで迎えてくれると思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0026")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:この仕事は<br>いつも人手不足だって聞いてるしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0027")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうなんですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:肉体労働的な側面もあるけど<br>ラシアは真面目だし頑張り屋だからきっと大丈夫
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ノワールって…<br>誘い文句が上手なんですね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0030")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうかな？<br>そんなつもりはなかったんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101037_0031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ふふっ<br>前向きに検討させてもらいますね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","AV_01_101037_0032")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
