-- このluaスクリプトは、MA_01104_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera008 = SetTemplate("Actor008",347,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera009 = SetTemplate("Actor009",11,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{0.587,0.035,-6.944,347})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor009,{-0.449,0.035,-6.773,11})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:でかした！<br>と言っていいわけだ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280002")

	PlayAction(Actor006,"to Sit01_Talk")
	change_face(Actor006,"Smile")

	--★★ガウェイン★★:アーサー様にも見せたかったぜ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01104_280003")


	--★★アーサー★★:見たかったァーッ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:戦果は届いている
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280005")

	PlayAction(Actor002,"to Sit01_Talk")

	--★★アーサー★★:なにを仏頂面でいるんだ義兄さん！<br>褒めてやれ！ほらっ、褒めてやれ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280006")


	--★★ノワール★★:ケイが<br>ガウェインを派遣してくれたって－－
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280007")


	--★★ケイ★★:殿下が欠ければログレスの損失だからだ<br>キャメリアードにも申し訳が立たん
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:まったく殿下のお転婆ぶりは目に余る…！<br>私がどれだけ頭を回しているか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280009")

	change_face(Actor006,"Normal")

	--★★ガウェイン★★:すげー早口だな
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01104_280010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:無事でなによりだ<br>ノワール
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280011")

	open_select_window_tag(Actor001,"Normal","MA_01104_280012","MA_01104_280013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ただいま
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280015")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…おかえり
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…それだけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280017")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…それだけだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280020")

	PlayAction(Actor003,"to Sit01_Talk")
	change_face(Actor003,"Laugh")

	--★★ランスロット★★:またこうして顔が見れて嬉しいよ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280021")

	change_face(Actor003,"Laugh")

	--★★ランスロット★★:『不格好なコート』の団長なら<br>難なくこなせる任務だと思っていた
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280022")

	goto Block1end

::Block1end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ランスロット★★:きちんと帰って来てくれて、良かった
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280024")


	--★★ケイ★★:カリバーン－－いや<br>最初の武器ティルフィング…だったか？
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280025")


	--★★ティルフィング★★:呼び名は、いかようにも
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_280027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:儀式なしでバルバロイを討ち倒し<br>GSなしでキラーズを得るなど－－
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280028")

	PlayAction(Actor002,"to Sit01_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:キャメロット学園において<br>前代未聞の事態だな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280030")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Surprise")

	--★★ガウェイン★★:…ぶっとび過ぎだぜオイ<br>なんなんだよお前…
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01104_280031")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:嬉しい誤算、というわけだ<br>円卓入りを認めないわけにはいかないな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:バルバロイを倒せる<br>キラーズも在る、誰が文句を言える？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280033")


	--★★ケイ★★:………ランスロットには<br>こうなることがわかっていたようだが
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280034")


	--★★ランスロット★★:そう祈っていただけだ。敬虔でね
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_280035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:アーサー、貴公は
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280037")

	PlayAction(Actor002,"to Sit01_Talk")
	change_face(Actor002,"Smile")

	--★★アーサー★★:学園に友達が増えたら楽しいなと！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280038")

	change_face(Actor004,"Sad")

	--★★ケイ★★:………ハーッ。幼少時からいつまで<br>貴公に振り回されれば済むのか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280039")


	--★★アーサー★★:ニッ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ケイ★★:笑ってごまかすな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280041")

	change_face(Actor004,"Normal")

	--★★ケイ★★:まあ…円卓の騎士としての適性は<br>座したあとでも見定められる
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:座せ座せ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:学内での立場が認められるかは別問題だがな
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280044")

	change_face(Actor006,"Laugh")

	--★★ガウェイン★★:…認めさせてみろよ。ノワール
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01104_280045")

	change_face(Actor002,"Normal")

	--★★アーサー★★:戦続きで人手不足だ<br>新参者にもすぐに働いてもらわねば
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280046")


	--★★ケイ★★:任務は追って通達する<br>しばらくは学園内で自由に過ごして構わん
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…いいんですか。そんなすぐに信用して<br>俺の父は－－
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280048")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:もはや出自を問う気はない<br>あとは剣で信頼を勝ち取ってみせよ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01104_280049")

	change_face(Actor002,"Smile")

	--★★アーサー★★:正当な評価として受け取ってくれると嬉しい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:座すべき者すべてに<br>平等なものでね
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_280051")

	open_cutin(1,1)
	on_cutin(1,Actor004,"Normal")

	--★★ケイ★★:スタンド・バイ・ユアラウンド
	Talk(Actor004,"CHRNAME_KAY","speech","N","MA_01104_280052")

	close_cutin()
-- ▼直接出力
voice_play("VO_101015_call_0002")
voice_play("VO_101010_call_0002")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Normal")
	on_cutin(2,Actor003,"Normal")

	--★★アーサー／ランスロット★★:
	Talk(Actor010,"CHRNAME_ARTHUR_LANCELOT","speech","N","MA_01104_281001")

	close_cutin()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:………フォー・ラウンド
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_280053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
