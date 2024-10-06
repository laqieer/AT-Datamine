-- このluaスクリプトは、MA_01C109_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
-- ▼直接出力
Include("content_adv_advsmall_110011_03","110011_03_h")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_008)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
-- ▼直接出力
movie_load("MA_01C109_01")
 --load_sound("SE_ADV_Movie")
-- ▲直接出力
-- ▼直接出力
 --movie_set_active(true)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
	--ちょっと特殊な対応
	set_pos(Actor001,CharaPos110011_03_013)
	set_rot(Actor001,{0,CharaPos110011_03_013[4],0}) 
	Camera001 = InitializeCharaCamera(CameraAssetBundleName110011_03, CameraPos110011_03_013, Actor001) --アクターのカメラを再設定
	--ここまで



	Chair_14 = get_object("geo_chair_14") --座り位置前の椅子しまう形に移動
	set_pos(Chair_14, {1.03,0,3.46})
	Chair_13 = get_object("geo_chair_13") --座り位置前の椅子しまう形に移動
	set_pos(Chair_13, {2.46,0,3.475})
-- ▲直接出力
-- ▼直接出力
load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Armoury")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon_D")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
-- ▼直接出力
Include("content_adv_advsmall_110011_03","110011_03_h")
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ブリテン島　６世紀　８月
	Talk(Actor005,"telop","narration","N","MA_01C109_010003")


	--★★テロップ★★:ブリテン東部を支配下に置いていた<br>カレドニアは
	Talk(Actor005,"telop","narration","N","MA_01C109_010004")


	--★★テロップ★★:その王ライエンスの死によって<br>混乱を極める
	Talk(Actor005,"telop","narration","N","MA_01C109_011001")


	--★★テロップ★★:さらに黒き怪異、不死の異民族―――<br>バルバロイは増殖の一途をたどっており
	Talk(Actor005,"telop","narration","N","MA_01C109_010005")


	--★★テロップ★★:世の乱れと共に出現すると言われる<br>『聖杯』の行方もいまだ知れず
	Talk(Actor005,"telop","narration","N","MA_01C109_010006")


	--★★テロップ★★:黒く押し寄せる歴史の波のなか<br>しばし訪れる安寧のとき
	Talk(Actor005,"telop","narration","N","MA_01C109_010007")


	--★★テロップ★★:せめて今だけは
	Talk(Actor005,"telop","narration","N","MA_01C109_010008")

-- ▼直接出力
CloseTalkWindow()
movie_set_active(true)
bgm_play("BGM_ADV_Armoury")
movie_play()
hide_image(0)
movie_wait_playing()
show_image("101010140_1", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
movie_stop()
change_area_scene(115014)
	--ムービー後待機
	wait_time(MOVIE_AFTER)
setup_small_camera_end()

-- ▲直接出力

	--★★テロップ★★:私を選ばなければよかったのに
	Talk(Actor005,"telop","simple","N","MA_01C109_010002")

-- ▼直接出力
CloseTalkWindow() 
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)

bgm_play("BGM_Area_Noon_D")
wait_time(3.0)

hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…兄さん？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020002")

-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………夢？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020003")

-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:寝ぼけてるの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020005")

	open_select_window_tag(Actor001,"Normal","MA_01C109_020006","MA_01C109_020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:…いや――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020009")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここは…教室か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:授業が終わったのに出てこないから<br>わざわざさがしにきたんだよ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:起こしちゃかわいそうだと思って<br>そのままにしておいてあげたんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
Appear(Actor004)
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:感謝してよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ、良く寝た<br>おはよう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:おはよう、じゃないわよ！<br>もうとっくに授業終わってるのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020016")

-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、夢を見ていて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020017")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
Appear(Actor004)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いい夢だったのか、悪い夢だったのか<br>…思い出せない、けれど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020018")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力

	--★★ギネヴィア★★:世話が焼けるわね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020020")

-- ▼直接出力
 --PlayPartVoice("ランスロット","挨拶")
-- ▲直接出力

	--★★ランスロット★★:どこまでを夢だと思ってるんだ？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020021")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ディナタンを選んだことも夢のつもり？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ブライアンさんたちのことは悲しいけど…<br>でも、がんばろうね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020023")

-- ▼直接出力
 --PlayPartVoice("ノワール","悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ああ、そうか、夢じゃないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020024")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:残念ながら夢じゃない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力

	--★★ギネヴィア★★:そうね、夢じゃないわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020026")

-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット★★:俺たちはお前の武器にはならなかったが<br>仲間であることに変わりはない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:そうね…それは変わらない
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020028")

	open_select_window_tag(Actor001,"Normal","MA_01C109_020029","MA_01C109_020030","MA_01C109_020031")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これからもよろしく<br>ギネヴィア、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020033")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:あたりまえよ<br>ローマを倒して聖杯を手に入れるんだから！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020034")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:我々の祖国を守るため<br>一緒に戦おう
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020035")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな<br>これからもよろしく、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:円卓の騎士のひとりとして<br>継承者の剣となるつもりだ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020038")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:わ、わたしにも<br>なにか声かけてよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020039")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな<br>これからもよろしく、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:うん！これからは雇い主じゃなくて<br>仲間のひとりとして協力していくわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C109_020042")

-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:無論、俺たち円卓の騎士も<br>協力は惜しまない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C109_020043")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さん、私――<br>私、兄さんの武器になれて嬉しい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンもこれからよろしく頼む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_020046")

-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ディナタン","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私が兄さんを守るね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_020047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01C109_01")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010140_1", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Armoury")
preload_sound("BGM_Area_Noon_D")
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
