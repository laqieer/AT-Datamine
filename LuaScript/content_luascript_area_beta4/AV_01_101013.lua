-- このluaスクリプトは、AV_01_101013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera002 = SetTemplate("Actor002",145,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:よう、ノワール！ちゃんとやってるか！？<br>…って、もしかしてもうあがりか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そうだけど…<br>ガウェインこそどうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0002")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:お前がここでバイトしてるって聞いたから<br>来てみたんだけど、一足遅かったみてーだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0003")


	--★★ノワール★★:それは残念だったな<br>…ていうか、冷やかし目的で来るなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そんなつれねーこと言うなって！<br>お前のことを心配して来たんだからよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0005")

	open_select_window_tag(Actor001,"Normal","AV_01_101013_0006","AV_01_101013_0007","AV_01_101013_0008")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:冷やかしじゃないなら手伝ってくれ<br>まだ後片付けが少し残ってるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0010")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:はあ！？俺、一応客で来たんだけど！？<br>客に手伝わせるのかよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガウェインは<br>困ってる人を放っておけないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0012")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…うっ。そ、そう言われたら<br>手伝ってやらなくもねーけどよ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ、冗談だよお客様<br>ちゃんともてなすから好きな席に座ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ったく、人をからかいやがって…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "気合い")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:こうなったら、片づけが面倒な料理を<br>山ほど料理を注文してやるからな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0016")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、お手柔らかに頼むよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでご注文は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0019")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:注文？ちゅ、注文か…<br>冷やかしのつもりだったんだけど…ブツブツ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:こっちのこと、こっちのこと！<br>ええっと、注文はだな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0022")

	PlayAction(Actor002,"to LookFor")
-- ▼直接出力
PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:………ワリ。今、金欠だったわ<br>一番安い料理で
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…やれやれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to Bow")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いらっしゃいませ<br>空いてるお席にどうぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0026")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おお、いいね！<br>サマになってるじゃねーか！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0027")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:いや、それよりお前もうあがりなんだろ？<br>帰らなくていいのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:せっかくガウェインが来てくれたんだ<br>応対しないわけにはいかないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そっか、ありがとな！<br>この店、結構遅くまでやってるだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0030")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:任務帰りとかで食べるのにちょうどいいんだよ<br>メニューも多いし、ボリュームも満点だしな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0031")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:まかないで出る料理も美味いぞ<br>メニューにはないオリジナルなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101013_0032")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:へえ！<br>今度食わせてくれよ、それ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AV_01_101013_0033")

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
	load_sequence_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
