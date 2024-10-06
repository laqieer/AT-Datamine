-- このluaスクリプトは、CO_101001_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	Camera002 = SetTemplate("Actor002",35,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いい眺めだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020002")


	--★★ノワール★★:ティルフィングは<br>ここが気に入ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020004")


	--★★ティルフィング★★:静かで、眺めも良くて…<br>考えごとをするのに向いていますから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:キミはいつもここで<br>どんな考えごとをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020007")


	--★★ティルフィング★★:世界のこと、人々のこと<br>私自身のこと…いろいろです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020008")


	--★★ノワール★★:いろいろ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:この学園のみなさんは<br>いい方ばかりです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020011")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:素性も明かさぬ私を受け入れ<br>親切にしてくださいます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:ここはとても<br>居心地がいいです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そっか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020015")


	--★★ノワール★★:ティルフィングもだいぶ<br>学園に馴染んできたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺としても嬉しいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020017")

-- ▼直接出力
PlayPartVoice("ティルフィング", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:いつもありがとうございます、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私は、この場所を守りたい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:今の私の力でできることは<br>それほど多くはないかもしれませんが
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020022")


	--★★ティルフィング★★:この地が、この場所が<br>ここに生きる人々がバルバロイに飲まれること
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:それだけはなんとしても防ぎたい<br>そう、強く思います
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺も、この場所を守りたい<br>俺にとっても、ここは大切な場所だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020028")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:継承者であるアナタのその想いが<br>私にとっての喜びとなります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020030")

	open_select_window_tag(Actor001,"Normal","CO_101001_05020032","CO_101001_05020033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば<br>初めて会ったときも継承者って呼ばれたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:思えばあのときが<br>すべての始まりでしたね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020036")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごく昔のように思えるのは<br>俺だけかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020038")

-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ふふっ、どうでしょう？<br>私とアナタの出会いは
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020040")

	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ついこのあいだのことかもしれないし<br>はるか昔から続いているのかもしれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:継承者って<br>いったい、なんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:アナタのみに<br>与えられている資格です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020044")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺だけに与えられた資格…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020046")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:世界のため、未来のために
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020048")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:私たちを語り継ぐことができる<br>唯一の存在――それが、継承者です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キラーズを語り継ぐっていうのは<br>どういうことなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020051")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…すみません<br>今は、まだ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:そっか…<br>ごめん、困らせて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020054")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:いいえ<br>でも、忘れないでください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020055")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_05020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:この場所を守りたいと言った<br>その気持ちを、どうか忘れないで
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020057")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:世界を救うには<br>アナタの力が、選択が、必要なのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_05020058")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
