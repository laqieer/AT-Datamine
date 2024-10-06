-- このluaスクリプトは、PT5_01_0045.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:今日は東の大国<br>カレドニア連合国について話していく
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450002")


	--★★ケイ★★:もともとカレドニアは<br>温厚だが日和見なライエンス王の統治のもと
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450003")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:山間に城を構える<br>小さな国だったのだが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:数年前に東部諸国が<br>この島の所有権をめぐって争いを始めると
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450005")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:漁夫の利を狙うような戦いかたで<br>カーライルをはじめとした１１の国を制圧
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450006")


	--★★ケイ★★:領土を今のように広げた
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450007")


	--★★ケイ★★:およそ５年前<br>現王ライエンスが遠征のさいに傷を負ってから
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")

	--★★ケイ★★:侵略の頻度は落ちたようだが<br>ブリテン統一の野望を失ってはいないようで
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450009")


	--★★ケイ★★:しばらく前のキャメリアード侵攻を皮切りに<br>今もログレスに戦争をしかけてきている
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450010")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT5_01_00450011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:私はカレドニアの動向には<br>かねてより目を光らせてきたつもりだが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450012")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:腑に落ちぬ部分があるのだよ
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00450014","PT5_01_00450015","PT5_01_00450016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ライエンス王って温厚な性格の人だったんだろ？<br>それがなぜ侵略行為をはじめたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00450017")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ケイ★★:うむ<br>しかもかなり性急にな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450018")

	change_face(Actor006,"Sad")

	--★★ケイ★★:ウワサによればライエンス王は<br>ある日を境に人が変わってしまったそうだ
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450019")

	change_face(Actor006,"Sad")

	--★★ケイ★★:それまでの温厚さがまるで嘘だったかのように<br>狡猾で残虐…人間らしさの欠片もない人物にな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:カレドニア軍は<br>バルバロイが紛れ込んでいるとも聞くな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00450021")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ケイ★★:うむ<br>それまでのカレドニアが弱い国とは言わぬが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450022")

	change_face(Actor006,"Normal")

	--★★ケイ★★:１１もの国を制圧するとなると<br>相応の武力が必要となってくるはずなのだ
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450023")

	change_face(Actor006,"Normal")

	--★★ケイ★★:それこそ人間を超越した<br>魔物のような力がな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:カレドニアは強い国だ<br>なにもおかしな点はないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00450025")

	change_face(Actor006,"Normal")

	--★★ケイ★★:…？
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450026")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ケイ★★:ああ、そうか<br>貴公はもともとカレドニアの傭兵だったのだな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450027")

	goto Block1end

::Block1end::
	change_face(Actor006,"Normal")

	--★★ケイ★★:王がまるで別人のような性格に豹変し<br>陣営にはバルバロイの姿すら見受けられる…
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450028")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:これがなにを意味しているのかは…<br>すべて説明するべくもないな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00450029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
