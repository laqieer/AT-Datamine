-- このluaスクリプトは、CO_101022_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	Camera002 = SetTemplate("Actor002",94,CharaPos110041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_001)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:こんなところにいたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030002")


	--★★ノワール★★:事後処理を全部俺とクラリスに押し付けてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:おー、終わったか？ご苦労さん
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030006")


	--★★ノワール★★:まったく…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あの貴族とその一派は牢屋行き学園でウワサを流したあいつはケイのお説教
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:だいたいこんなところだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030009")

-- ▼直接出力
PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力

	--★★モルドレッド★★:ははは！ケイのお説教なんてオレなら死んでもごめんだな！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そこ笑うとこか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:一件落着できたのはいいんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーと俺たちが敵対することがなかったら今回のことも起こらなかったのかと思うと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030014")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:なんだか複雑な気分だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オレは――王になるぜ、ノワール
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:バカに担がれての王じゃねえぜ？自らの足で立つ、本物の王だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:オレは王になってアーサーと直接雌雄を決する
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そうしねえと、気が済まねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030023")

	open_select_window_tag(Actor001,"Normal","CO_101022_10030025","CO_101022_10030026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:直接対決か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ちょっと楽しみだ…っていうのはさすがに不謹慎かな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:ははは！いいじゃねえか、豪胆でオレは嫌いじゃねえぞ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030031")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:楽しみにしときな退屈はさせねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:勝てるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030035")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:逆に聞くがよ勝てる戦しかやらねえのか？おめえは
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030036")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう言われると…答えはノーだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:だよな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030038")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:剣術部のあの泣き虫もオレを担ごうとしたコウモリ貴族も
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030040")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:アーサーが学園に居続ければああなることはなかっただろう
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:あいつらは――アーサーが棄てたものの、成れの果てだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030042")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーが、棄てたものの…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:そうだ。奴は棄て去った
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030044")


	--★★モルドレッド★★:学園も、民も、あいつを信じた者たちすべてを己の理想を実現するには無用な重荷だと
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030045")


	--★★モルドレッド★★:今まで背負ってきたものすべてを棄てて去っていったのが今のアーサーだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:オレは許さねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030048")


	--★★モルドレッド★★:今まであいつを信じてついて来た者人生を捧げた者、慕ってくれた者、殉じた者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★モルドレッド★★:そいつら全部に裏切りと絶望を与えたあのヤロウの所業をオレは許す訳にはいかねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030050")


	--★★ノワール★★:モルドレッド…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:あいつが棄てたものは全部拾ってやる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030052")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030053")


	--★★モルドレッド★★:あいつが棄てた全部を拾って背負って、すべてをこの手に収めたうえで――
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:あいつと雌雄を決するんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ――できるさ、モルドレッドなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:見逃すなよ、継承者？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030060")


	--★★モルドレッド★★:ちゃんとその目に焼き付けて、記憶しておけ王のすべてを
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10030061")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:責任重大だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10030063")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
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
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
