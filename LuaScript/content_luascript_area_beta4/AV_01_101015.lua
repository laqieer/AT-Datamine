-- このluaスクリプトは、AV_01_101015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:おおっ、ノワールじゃないか！？<br>ここに店を出しているとは知らなかったぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:わざとらしい。わかってて言ってるだろ<br>マルイルの店の手伝いだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力

	--★★アーサー★★:偉い、偉いぞノワール！<br>若者はよく学び、よく働くべきだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…それはどうも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0004")


	--★★ノワール★★:で？そういうアーサーは<br>マーケットになにしに来たんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:いや、なに。ちょっと小腹が空いてなそうだ、なにか食わせてくれないか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0006")


	--★★ノワール★★:ちょうど手伝いが終わったところなんだけど…なにかあったかな？ちょっと待ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101015_0008","AV_01_101015_0009","AV_01_101015_0010")
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
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪い<br>今、食品類は切らしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0012")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:そうか！<br>残念だが、しかたがないな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:他の店を見て回るとしよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0014")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ところで、ケイやマーリンさんに<br>出かけていることを伝えているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0015")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:…そ、それはその………アレだ、大丈夫だ！<br>だから店番頑張るんだぞ！ではな！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0016")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.3, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_active(Actor002)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…黙って出てきたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩み")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これなんてどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:マルイル曰く、最近出回るようになった<br>新商品らしいぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:細切れにした肉を<br>小麦で作った生地で包んで蒸したものらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0021")

	PlayAction(Actor002,"to EatIdle")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:新商品か？それは興味深いな<br>ひとつもらうとしよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0022")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:………ウマい！これはウマいな！<br>ログレスでもっと流行らせなくてはいかん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:イイものを教えてくれて感謝するぞ<br>ノワール！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そんなに喜んでくれるとは思わなかった<br>マルイルにも伝えておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:フィッシュアンドチップスならあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0027")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:マルイルがアーサー王の好物は欠かさず<br>仕入れているって言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0028")

-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:それはありがたい！<br>では、ひとつもらえるか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:うん、うん…ウマい！<br>やっぱりこの味は安心するな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0030")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ノワールも食べてみるといい<br>ウマいぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AV_01_101015_0031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いや、今は腹が減ってないから大丈夫だ<br>アーサーが満足してくれたようで良かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101015_0032")

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
	load_sequence_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
