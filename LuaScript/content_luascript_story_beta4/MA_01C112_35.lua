-- このluaスクリプトは、MA_01C112_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_351001")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_351002")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_351003")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_351004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ケイ★★:我々は大きな痛手を負った<br>パーシヴァル…ランスロットたちもいない
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01C112_350002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…パーシヴァル…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350003")

	change_face(Actor005,"Normal")

	--★★ケイ★★:そんななかではあるが、斥候部隊が<br>ランスロットたちの居場所をつかんでくれた
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01C112_350004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:ケイ卿<br>物事は正確に伝えるべきだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350005")

	change_face(Actor004,"Normal")

	--★★ルーシャス★★:「ローマ軍の斥候部隊が」とな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350006")


	--★★ケイ★★:…聞いての通りだ<br>ランスロットたちはアバドンにいるらしい
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01C112_350007")

-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力

	--★★トリスタン★★:魔女の話は本当だったってことか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_350008")

-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力

	--★★モルドレッド★★:アーサーとは一緒じゃねえのか？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350009")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:それもわからない
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:一番大事なことがわかってねえのかよ<br>ローマ軍の斥候部隊は役立たずだな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350011")

	change_face(Actor004,"Normal")

	--★★ルーシャス★★:行ってみればわかることだ<br>わざわざ調べるまでもない
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350012")


	--★★トリスタン★★:とはいえ、アーサーとガウェインが<br>いるかいないかで戦況は大きく変わる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_350013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:さて<br>継承者よ、決断は？
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01C112_350014")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ノワール★★:俺は…<br>ランスロットを助けに行きたい
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C112_350015")

	close_cutin()

	--★★モルドレッド★★:その理由は？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_350017","MA_01C112_350018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーに対抗するには戦力が必要だ<br>…聖杯が失われた今ならなおさら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350020")

	change_face(Actor003,"Smile")

	--★★モルドレッド★★:ふん…ま、オトモダチを助けたいなんて<br>ガキみてえな理由吐かれるよりはマシだな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それもあるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350022")

	change_face(Actor003,"Surprise")

	--★★モルドレッド★★:あ？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350023")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:…失われた聖杯の穴を埋めるには<br>最強騎士といえど荷が重かろうな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:かけがえのない仲間だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350026")

	change_face(Actor003,"Normal")

	--★★モルドレッド★★:ケッ<br>言うと思ったぜ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350027")

	change_face(Actor004,"Normal")

	--★★ルーシャス★★:珍しく意見が合ったな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350028")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしランスロットと俺の立場が逆なら<br>きっと同じことをしたと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350030")


	--★★ノワール★★:そして以前のアーサーも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350031")

	change_face(Actor003,"Surprise")

	--★★モルドレッド★★:…チッ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:ボクはいいと思うけど、他はどう？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C112_350033")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ルーシャス★★:今回はノワールの決断に従おう
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350034")

	change_face(Actor003,"Normal")

	--★★モルドレッド★★:ローマの皇太子が手のひら返しかよ<br>笑えねえなァ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350035")

	change_face(Actor004,"Normal")

	--★★ルーシャス★★:一度受けた恩はきっちりと返させてもらう<br>それがローマの流儀だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350036")


	--★★ルーシャス★★:浅慮でただ噛みつくだけの<br>狂犬といっしょにされては困る
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01C112_350037")


	--★★モルドレッド★★:…てめえ<br>事態が収束したらきっちりカタつけっかんな
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:…とはいっても<br>今は逆らう意味がねえのは確かだ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C112_350039")


	--★★ケイ★★:では、決まりだな
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01C112_350040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ああ。アバドンに向かい<br>ランスロットとギネヴィアを救う！?
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_350041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
