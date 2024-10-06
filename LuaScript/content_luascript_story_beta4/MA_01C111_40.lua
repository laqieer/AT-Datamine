-- このluaスクリプトは、MA_01C111_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera007 = SetTemplate("Actor008",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("102040010_StillImage", "content_still_10204001_image", "102040010_StillImage")
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:一度は裏切られた相手だが<br>ローマを味方につけられれば大きな戦力になる
	Talk(Actor007,"telop","narration","N","MA_01C111_401001")


	--★★テロップ★★:円卓の騎士たちは魔女の動向を探りつつ<br>今後の対応を決めるため、円卓の間に集う
	Talk(Actor007,"telop","narration","N","MA_01C111_401002")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01C111_401003")


	--★★テロップ★★:先日、ロンディニウムの近くで<br>魔女らしき影を見たとの報せが入っている
	Talk(Actor007,"telop","narration","N","MA_01C111_401004")


	--★★テロップ★★:ハロウィンで魔女の力が増大したのかね<br>おとぎ話かと思ってたぜ
	Talk(Actor007,"telop","narration","N","MA_01C111_401005")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ","肯定2")
-- ▲直接出力

	--★★ケイ★★:先日、ロンディニウムの近くで<br>魔女らしき影を見たとの報せが入っている
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400006")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","納得")
-- ▲直接出力

	--★★モルドレッド★★:ハロウィンで魔女の力が増大したのかね<br>おとぎ話かと思ってたぜ
	Talk(Actor006,"CHRNAME_MORDRED","speech","L","MA_01C111_400007")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル","悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:可能性はあるかもね。やれやれ…<br>ただのおとぎ話であってくれたらよかったのに
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:アーサーの行方は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:今のところは不明だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400010")

-- ▼直接出力
 --PlayPartVoice("ランスロット","悩む")
-- ▲直接出力

	--★★ランスロット★★:魔女を追えば<br>アーサーにたどり着けるかもしれない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400011")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル","肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:その口ぶり<br>貴方には心当たりがあるみたいだね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:…あぁ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル","怒り")
-- ▲直接出力

	--★★パーシヴァル★★:だとしたら、魔女を追わない理由はないよ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400014")

	change_face(Actor004,"Anger")

	--★★パーシヴァル★★:ボクは必ずアーサーを見つけ出して<br>裏切りの報いを受けさせる
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400015")


	--★★パーシヴァル★★:魔女をちゃちゃっと倒したら<br>次はその足でアーサーをさがすんだ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド","納得")
-- ▲直接出力

	--★★モルドレッド★★:ちゃちゃっと、ねぇ…？
	Talk(Actor006,"CHRNAME_MORDRED","speech","L","MA_01C111_400018")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル","激怒")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:…なんだよ<br>キミ、なにが言いたいんだい
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400019")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド","笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★モルドレッド★★:別に？珍しく気が合うなと思っただけだ<br>じゃあ問題はどっちの魔女を相手にするかだな
	Talk(Actor006,"CHRNAME_MORDRED","speech","L","MA_01C111_400020")

-- ▼直接出力
 --PlayPartVoice("ケイ","悩む")
-- ▲直接出力

	--★★ケイ★★:ルーシャスとともにいる魔女と<br>ロンディニウムに現れた魔女、どちらを先に――
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_400022","MA_01C111_400023","MA_01C111_400024")
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
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:期日が迫っているんだろう？<br>遅くなればルーシャスの身に危険が及ぶ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はルーシャス側の魔女を<br>先に片付けるのがいいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ","納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:ルーシャスからアーサーの動向を<br>聞くこともできるであろうし、よい選択と思う
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400028")

	change_face(Actor003,"Sad")

	--★★ケイ★★:だが、ロンディニウムに現れた魔女が<br>こちらに押し寄せないかが心配だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ロンディニウムならログレスから近い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そちらから魔女を片付けて<br>ルーシャスのもとに向かうのはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400032")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ","否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:間に合う可能性はゼロでないが<br>魔女がどこまで気長かにもよるであろうな
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C111_400033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:手分けして同時に叩けないだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400035")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★モルドレッド★★:戦力を分散するのは得策とは思えねえな
	Talk(Actor006,"CHRNAME_MORDRED","speech","L","MA_01C111_400036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺はその意見に賛成だ<br>後顧の憂いを断つ意味でもな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400037")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:意見をまとめると<br>どちらも捨て置くことはできなさそうだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400039")

-- ▼直接出力
CloseTalkWindow()
show_image("102040010_StillImage", 0.0, 0.0, 0.3,false,false)
wait_time(0.6)
-- ▲直接出力

	--★★ランスロット★★:ギネヴィアと俺はロンディニウムを防衛する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400040")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力

	--★★パーシヴァル★★:ボクも行こう。ロンディニウムの人々を<br>放っておくわけにはいかないからね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01C111_400041")

-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット★★:では、ロンディニウムへは<br>この３人で向かうとしよう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:ノワールはディナタンを連れて<br>ルーシャスのもとに行ってくれるか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_400044")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_400045")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102040010_StillImage", "content_still_10204001_image", "102040010_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
