-- このluaスクリプトは、MA_01B112_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_pos(Actor001,{-0.85,-0.155,-5.12})
set_pos(Actor002,{-0.909,-0.155,-3.372})
set_pos(Actor003,{1.82,-0.155,-4.43})
set_pos(Actor004,{0.1,-0.155,-4.95})
set_pos(Actor005,{0.84,-0.155,-5})
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","002","101010002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101056","002","101056002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101053","002","101053002","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ペレス★★:痛みは増すばかりで<br>死は間近に迫りつつある
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280002")

-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力

	--★★ペレス★★:その前に、せめてその前に──
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01A112_18_Door")
-- ▲直接出力
-- ▼直接出力
wait_time(2.7)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,-0.85,-0.155,-7.12,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,-0.909,-0.155,-5.372,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,1.82,-0.155,-6.43,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,0.1,-0.155,-6.95,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,0.84,-0.155,-7,1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★ペレス★★:おお…<br>ノワール卿、ランスロット卿
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:ガラハッドとフィエナが<br>帰参いたしました、お爺様
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280007")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★アーサー★★:ペレス王………前置きなしで伺うが<br>ギネヴィアとマーリンは何処か
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_280008")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★ペレス★★:さてな
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_280010","MA_01B112_280011","MA_01B112_280012")
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
	change_face(Actor001,"Anger")

	--★★ノワール★★:ペレス王…俺たちは貴方の庇護を必要とはしない<br>継承者としてバルバロイを根絶する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ランスロット★★:ノワールはその力も覚悟も兼ね備えている<br>貴方の気遣いは無用に願いたい
	Talk(Actor002,"CHRNAME_LANCELOT2","speech","L","MA_01B112_280015")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ペレス★★:異なことを申すな
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ノワール★★:ガラハッドにかける言葉はないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280018")

	change_face(Actor006,"Normal")

	--★★ペレス★★:バルバロイに食い潰されようという老いぼれから<br>なにか言葉が欲しいか？
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280019")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:…不要です、お爺様<br>ガラハッドが貴方の顔を見たくて来ました
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Anger")

	--★★ノワール★★:アーサーをやらせはしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280022")

	change_face(Actor006,"Normal")

	--★★ペレス★★:御足労いただいたうえ<br>ただ帰すわけにもいくまい？
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280023")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Anger")

	--★★アーサー★★:わざわざ人質をとっておいて<br>その物言いは尊大だな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_280024")

	goto Block1end

::Block1end::
	change_face(Actor006,"Normal")

	--★★ペレス★★:聖杯解放、世界救済…その果てに<br>継承者とその劒の安寧はないというのに
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280026")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:…どういう意味です
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★ペレス★★:………聖杯が真にあらゆる願いを叶えられれば<br>どれだけ良いことか
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280029")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…聖杯は<br>願望を叶える器、というわけではない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280031")


	--★★ペレス★★:そう伝承されれば<br>人はそれを求めるであろう？
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280033")


	--★★ペレス★★:なんとしても選ばれし者の手に渡すべく<br>そう伝えられたのだろうて
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Anger")

	--★★フィエナ★★:なに、それ…！？<br>願いが叶うからって私たち探してきたのに…！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_280035")


	--★★ペレス★★:おおよそ万人の願うことは叶うであろうな
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ペレス★★:万人が望み…<br>大切な者との思い出や記憶、生きた証を残すこと
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280037")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:聖杯はそれを叶えることができる<br>──『聖域化』のための唯一の鍵だ
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガラハッド★★:『聖域化』………？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280039")


	--★★ペレス★★:聖杯には万象の力が宿ると伝えられている<br>つまり世の穢れに対抗できる武器たる力──
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280040")

-- ▼直接出力
setup_small_camera_start(RndCamera010)
-- ▲直接出力

	--★★ペレス★★:キラーズ因子が満ちた杯<br>それこそが聖杯だ
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280042")

	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Sad")

	--★★フィエナ★★:…<ruby=それ>聖杯</ruby>自体がバルバロイに対抗するための──<br>ブリテンの地が産んだ武器、ってこと…？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_280043")


	--★★ペレス★★:継承者がしかるべき場所にて聖杯を使えば<br>ブリテン全域に因子の力が染み渡る
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（しかるべき場所──<br>『サラスの都』…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B112_280046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:バルバロイに相反するキラーズ因子の力を<br>島中に行きわたらせることができると…？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280047")


	--★★ペレス★★:そうして聖域を形成する途上で<br>地を蝕んでいた穢れが浮き上がり──…
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280048")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:最後に訪れるのが、淘汰の刻
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:（淘汰…授業でやった<br>歴史の節目に訪れるといわれる大いなる禍…）
	Talk(Actor004,"CHRNAME_GALAHAD","mind","L","MA_01B112_280051")


	--★★ペレス★★:淘汰に伴い<br><dot>穢れの中心点</dot>が具現化する
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:穢れの中心点──<br>つまり、バルバロイの集合体のような？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280054")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:それを継承者のキラーズで貫き<dot>封</dot>じることで…<br>『聖域化』は成し遂げられる
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280056")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Normal")

	--★★フィエナ★★:………意外に、あっけないっていうか<br>シンプルっていうか…
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_280058")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Surprise")

	--★★ガラハッド★★:つ、つまりそのバルバロイの親玉を倒せば<br>すべては済む、ということですか…？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B112_280059")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:さすればこの地は『聖域』となり<br>継承者のキラーズはバルバロイ根絶の封となる
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:封………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_280062")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ペレス★★:継承者はすでに目の当たりにしているはず<br>聖域化の跡を
	Talk(Actor006,"CHRNAME_PEREZ","speech","R","MA_01B112_280063")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","002","101010002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101056","002","101056002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101053","002","101053002","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
