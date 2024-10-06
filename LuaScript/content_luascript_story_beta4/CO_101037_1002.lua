-- このluaスクリプトは、CO_101037_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ふう、ごちそうさま
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:お粗末様でした
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020003")


	--★★ラシア★★:ローマからの難民のみなさんにも<br>このヨーグルトを差し上げたんですけど
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:すごく評判よかったんですよ<br>「ローマを思い出した気がする」って
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、そうなのか！<br>頑張ってるんだな、ラシア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力

	--★★ラシア★★:あの…いろいろとありがとうございました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020007")


	--★★ラシア★★:ヴェルナルス様との距離の話…<br>懐に飛び込んでみろって
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、うまくいった？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:…そう思います
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラシア★★:他愛もないことを話してみたんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020011")


	--★★ラシア★★:学園でどんなことがあったとか<br>街に最近できたお店の話とか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:ノワールと読んだ絵本の話もしたら<br>「懐かしいな」って言ってましたね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020013")

	open_select_window_tag(Actor001,"Normal","CO_101037_10020015","CO_101037_10020016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ヴェルナルス先生は知ってたのか<br>あの物語って有名なんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020018")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:有名かどうかはわかりませんが<br>ノワールより詳しかったですよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020019")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺には遠慮しないで<br>ガンガンくるんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:あっ、ご、ごめんなさい！<br>怒らせるつもりはなかったんです…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:冗談だよ<br>ぜんぜん怒ってない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:上手くいったんだな<br>良かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020025")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:他愛もない雑談ができるようになったなんて<br>大きな前進じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:私もビックリしました<br>勇気を出した甲斐がありました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020027")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ノワールには本当に感謝しています<br>何度も何度も私の背中を押してくれて
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020029")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もヨーグルトをご馳走になってるし<br>お互いさまってことで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020030")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData110122_01_01,CameraAssetBundleName110122_01,CameraPos110122_01_101)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ヴェルナルス先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020032")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:ヴェルナルス様…じゃない、先生！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:…ヨーグルトか
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_10020034")

-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ご一緒にいかがですか？<br>先生の好きなコケモモのジャムもありますよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020035")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "悩む")
-- ▲直接出力

	--★★ヴェルナルス★★:これからローマの難民受け入れの会議がある<br>それが終わってからでもいいか？
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_10020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:もちろんです！それから<br>私にできることがあれば言ってください
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020037")


	--★★ラシア★★:フレンとローラも手伝いたいって言ってました！<br>声をかけたらきっと他の生徒も…！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定2")
-- ▲直接出力

	--★★ヴェルナルス★★:ああ…そうだな<br>その気持ちはありがたい
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_10020040")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴェルナルス★★:まずは住居と食料の確保が必要だ<br>あとでそのあたりのことを相談させてもらう
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_10020041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:わかりました！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020042")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力

	--★★ヴェルナルス★★:…では
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_10020043")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:あれ？<br>食堂に来たのになにも食べていかないんですね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ラシアの様子を見に来たんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力

	--★★ラシア★★:ええっ、まさか！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラシア★★:それよりノワールも住居や食料のこと<br>一緒に考えてくれませんか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020048")


	--★★ラシア★★:私よりノワールのほうが<br>学園や市街に知り合いが多いですよね？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:騎士たる者――
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力

	--★★ノワール★★:女性には優しくしますよ<br>…もう靴は拾わないかもしれないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_10020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:もう落としません！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_10020053")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
