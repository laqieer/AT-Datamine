-- このluaスクリプトは、CO_101015_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor004,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール2★★:あ…いた！<br>あんなところでなにしてるんだ？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","CO_101015_02030002")


	--★★ノワール2★★:（王様だってのに、護衛もつけずに<br>町の人と飯を食いながら話すとか…）
	Talk(Actor005,"CHRNAME_NOIR","mind","L","CO_101015_02030003")


	--★★ノワール2★★:（確かに、王様の威厳とは遠い感じかもな）
	Talk(Actor005,"CHRNAME_NOIR","mind","L","CO_101015_02030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力

	--★★市民（男）②★★:ホットドッグにカツサンドって<br>王様なのに庶民派の舌をしてますねぇ
	Talk(Actor003,"NPCNAME_0194","speech","L","CO_101015_02030005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "照れ")
-- ▲直接出力

	--★★アーサー★★:そうか？このカツサンドなんて<br>宮廷料理に引けを取らん旨さだぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030006")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_女1", "笑い")
-- ▲直接出力

	--★★市民（中年女）★★:それは言い過ぎですって！
	Talk(Actor004,"NPCNAME_0195","speech","L","CO_101015_02030007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★市民（中年女）★★:まぁ、私たちの好きなものを美味しいと<br>言ってくれるのは嬉しいですけどね
	Talk(Actor004,"NPCNAME_0195","speech","L","CO_101015_02030008")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:旨いものの前に王も庶民もないからな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:ところでみんな、困っていることはないか？　
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:なにかあれば相談してくれ<br>俺がここでカツサンドを食べているあいだにな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030011")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）②★★:うーん。今のところはないですね
	Talk(Actor003,"NPCNAME_0194","speech","L","CO_101015_02030012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女1", "肯定")
-- ▲直接出力

	--★★市民（中年女）★★:円卓の騎士たちが見回ってくれるおかげで<br>町は安全ですし
	Talk(Actor004,"NPCNAME_0195","speech","L","CO_101015_02030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）②★★:アーサー様がいつも気にかけてくれるから<br>私たちはこうして安心して暮らせてますよ
	Talk(Actor003,"NPCNAME_0194","speech","L","CO_101015_02030014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そうか。それはよかった！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030015")


	--★★アーサー★★:だが、なにか気になることがあったら<br>いつでも言ってくれよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030016")


	--★★ノワール2★★:（…威厳はないかもだけど…）
	Talk(Actor005,"CHRNAME_NOIR","mind","L","CO_101015_02030018")

-- ▼直接出力
　--時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor001)
Hide(Actor003)
Hide(Actor004)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:すまないな<br>待たせてしまった！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:気づいてたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:あれだけ熱い視線を向けられればな<br>義兄さんから頼まれたんだろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030022")


	--★★アーサー★★:ムリヤリ連れていくこともできただろうに<br>お前は優しい男だな、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030023")

	open_select_window_tag(Actor001,"Normal","CO_101015_02030025","CO_101015_02030026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:別に、そんなんじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ…思ったよりちゃんと<br>王様してるんだな、とは思った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030029")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:俺がか？<br>ハハハ！それはどうだろうな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:ちゃんとした王様はデスクワークから逃げて<br>義兄を泣かせたりせんと思うが？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030031")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…そうかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あと数分待ってもあそこを動かないなら<br>連れ戻そうと思ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030034")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:それは危ないところだったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030035")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:もしも<br>あのカツサンドを最後まで食えなかったら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030036")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★アーサー★★:悲しみのあまり<br>俺の心は張り裂けていたことだろう！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030037")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そんなにか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030038")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにしても、なんであんたはあんな場所で<br>みんなの相手をしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030040")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:なにかおかしいか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030041")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:いや、おかしくはないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:王様ってのはこう…<br>お城でふんぞり返ってるもんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030043")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:すがすがしいまでの偏見だ！<br>お前のそういうところ、正直でいいと思うぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030044")

	change_face(Actor002,"Normal")

	--★★アーサー★★:だが高い位置に立って見下ろしているだけでは<br>本当に大事なことは見えてこないものだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030045")


	--★★アーサー★★:同じものを同じ目線で食べることで<br>民のことをより深く知ることができるのさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030046")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:円卓の精神、ってやつか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030047")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そうだな。俺のような人間に対しても<br>同じ目線で接してくれる仲間がいてくれる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:だからこそ、今の俺があるんだ<br>俺は皆と同じ目線に立てる王でありたい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:…Ｂ級グルメを食べるのに<br>そんな深い理由があったとは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030050")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:立派な王様過ぎて、目が眩んだか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:自分で言うことじゃないと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030052")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:ハハハ！確かに！<br>…さて、美味いカツサンドで腹も満たされた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030053")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:次はドリンクが欲しいところだな<br>飲んだらすぐに眠くなるくらい甘～いヤツが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02030055")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:公務に戻るんじゃないのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02030056")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
