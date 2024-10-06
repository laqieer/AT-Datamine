-- このluaスクリプトは、MA_01A900_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_003)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
-- ▼直接出力
set_pos(Actor002,{-1.99,0,-3.849})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,0.49233, 0.8, -0.211)
lookat_weight(Actor003,0.7,0.03,0.6,0.3)
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",0.5)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
CameraLucius = set_camera({0.56, 1.69, -1.42,   5.29614, 28.45113, 359.9766,   29})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-3.589, 2.038, -1.387,   12.68699, 78.96748, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.14, 1.89, -3.44,   11.48413, 15.90711, 0.00614,   29})
-- ▲直接出力
-- ▼直接出力
CameraEx_03 = set_camera({-2.508, 1.72, -2.982,   5.1, 50.69999, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_04 = set_camera({4.26, 2.26, -3.06,   13.69999, 302.9, 359.991,   30})
-- ▲直接出力
-- ▼直接出力
CameraEx_05 = set_camera({-4.697, 2.114, -1.934,   12.172, 62.19999, 359.983,   30})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101051","003","101051003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","003","101038003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","003","101039003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ギネヴィアの願いに応じ<br>ノワールは彼女と剣の祭壇を訪れる
	Talk(Actor004,"telop","narration","N","MA_01A900_061001")


	--★★テロップ★★:覚悟を決めたはずのギネヴィアだが<br>行き場のない感情が溢れ、遂には倒れてしまう
	Talk(Actor004,"telop","narration","N","MA_01A900_061002")


	--★★テロップ★★:ギネヴィアを連れて行かないで、ギネマウアに<br>そう懇願されますます選択を迷うノワール
	Talk(Actor004,"telop","narration","N","MA_01A900_061003")


	--★★テロップ★★:一方、魔女の力と知識を手にしたルーシャスは<br>未だ目立った動きを見せないでいた
	Talk(Actor004,"telop","narration","N","MA_01A900_061004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★フレン★★:やっとお揃いだね…ローラ
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ルーシャス★★:儚き夢だな、愛しき小鳥
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060003")

	change_face(Actor003,"Normal")

	--★★フレン★★:君が与えてくれたんだよ<br>妹を守る力も、妹と同じ居場所も
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:武器として利用してやっただけだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★フレン★★:ふふ…私もそう<br>利用させてやっただけ
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060006")

	change_face(Actor001,"Smile")

	--★★ルーシャス★★:クク…口に出してはみるものの<br>愛などついぞ理解し得なかったよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060008")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:愛だ絆だと互いを擦り<br>削り合ったログレスはどうなった？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060009")


	--★★ルーシャス★★:まもなくバルバロイに呑まれんとしている
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ルーシャス★★:愛する者のために版図を拡げ続けたローマ本国も<br>大陸で腐敗と衰退の一途を辿っている
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060011")

-- ▼直接出力
setup_small_camera_start(CameraLucius)
slidemove(CameraLucius,0.47,1.71,-1.59,15)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:その点バルバロイは潔いじゃないか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060012")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:使える者は取り込み増殖し<br>使えぬ者は喰らって栄養とする
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060013")


	--★★ルーシャス★★:人がバルバロイという強靭な種と混ざり合えれば<br>愛や生死、飢餓や病という概念を超越できる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060014")

	change_face(Actor001,"Smile")

	--★★ルーシャス★★:人間どもが騙る綺麗事──<br>その飾りを剥ぎ取ってな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060015")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-3.637,2.038,-1.142,15)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フレン★★:ルーシャスくんの夢は本当にそれなの？<br>聖杯なしに君の想いはそれで果たされるの？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060017")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:魔女の知を得てわかったよ<br>聖杯は認められた者にしか使えぬ代物だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060018")


	--★★ルーシャス★★:願望機としても万能とは言えぬのかもしれん<br>継承者の劔が力を宿したところで大勢は揺らがぬ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060019")

	change_face(Actor003,"Normal")

	--★★フレン★★:君の夢を聞かせてよ、いいでしょ？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:そなたが知る必要はない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060022")

	change_face(Actor003,"Laugh")

	--★★フレン★★:神様には<br>信徒と経典が必要だよ
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:…バルバロイの胃袋を掴むのだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★フレン★★:ふふ。なにそれ<br>誰かに料理でも振る舞うの？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060026")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ルーシャス★★:間もなく余らが辿り着くは歴史の分岐点<br>世界の自浄…すなわち『淘汰』が起こる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","N","MA_01A900_060027")

	on_cutin(1,Actor001,"Normal")

	--★★ルーシャス★★:継承者の登場と成熟、聖杯出現、聖域化の前触れ<br>世界に蓄えられた記憶が<ruby=しきい>閾</ruby>値を超える
	Talk(Actor001,"CHRNAME_LUCIUS","speech","N","MA_01A900_060029")

	on_cutin(1,Actor001,"Smile")

	--★★ルーシャス★★:その予兆こそ<br>あの不気味な空だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","N","MA_01A900_060031")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.1)
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,0.27,1.79,-2.98,10)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:淘汰の渦から現れるはバルバロイの中心点<br>魔女を喰った余の力で、それと同化を果たす
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★フレン★★:…魔女に従うフリをしながら姉妹たちを削って<br>モルガンを疲弊させた苦労が報われるね
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060033")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ルーシャス★★:さすればな、どうなると思う？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060034")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:<ruby=バルバロイ>奴ら</ruby>が過去に胃袋へ呑み込んだ人々の存在…<br>そのすべて手中に収めることができるのだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060035")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:バルバロイが喰らった者たち、蓄えたその記憶…<br>中心点からそれらに接続することが可能となる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060037")

	change_face(Actor003,"Surprise")

	--★★フレン★★:………ユーサーに奪われたローマの民も<br>虐殺で喰われたロンディニウムの人たちも…！？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:余がみなの存在を担えば、ともにいられる<br>余がみなの存在を覚え続けてやれば、未来永劫な
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060039")


	--★★フレン★★:それが「ローマによる平和」…<br>すべての道がルーシャスくんに通じて──
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060040")

	change_face(Actor003,"Normal")

	--★★フレン★★:ルーシャスくんが<br>バルバロイの中心点としてずっと
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060042")

	change_face(Actor003,"Sad")

	--★★フレン★★:ずっとひとりで<br>みんなの存在を担っていくの…？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060043")

-- ▼直接出力
setup_small_camera_start(CameraEx_03)
slidemove(CameraEx_03,-2.521,1.528,-2.993,15)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:なあに、慣れっこだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★フレン★★:…お母様にも会えるね
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:…忘れよ<br>恥ずべき感慨であった
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A900_060046")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★フレン★★:うん。すぐに忘れるよ
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060047")


	--★★フレン★★:だけど小鳥は<br>君の隣で休むから
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060048")

-- ▼直接出力
 --ローラ入場
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor001,true)
CloseTalkWindow()
on_active(Actor002)
turn_lookat_position(Actor002,CharaPos111031_01_007[1],CharaPos111031_01_007[2],CharaPos111031_01_007[3],0)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,CharaPos111031_01_007[1],CharaPos111031_01_007[2],CharaPos111031_01_007[3],2.5)
wait_time(0.5)
setup_small_camera_start(CameraEx_04)
slidemove(CameraEx_04,4.32,2.26,-2.97,12)
wait_time(2.0)
turn_chara(Actor002,CharaPos111031_01_007[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ローラ★★:フレンお姉様<br>ほかのお姉様たちはどこに？
	Talk(Actor002,"CHRNAME_LOLA2","speech","L","MA_01A900_060050")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力

	--★★フレン★★:…みんな円卓の騎士に倒されちゃった
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060051")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ローラ★★:私にはもう…フレンお姉様しか
	Talk(Actor002,"CHRNAME_LOLA2","speech","L","MA_01A900_060052")

-- ▼直接出力
setup_small_camera_start(CameraEx_05)
-- ▲直接出力

	--★★フレン★★:ローラ、忘れる前に<br>最後にひとつお願いしてもいい？
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060053")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★フレン★★:忘れる前みたく、呼んでほしいの
	Talk(Actor003,"CHRNAME_FREN2","speech","L","MA_01A900_060054")

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
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101051","003","101051003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","003","101038003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","003","101039003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
