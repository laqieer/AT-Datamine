-- このluaスクリプトは、CO_101015_0404.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",110,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	Camera002 = SetTemplate("Actor002",65,CharaPos110041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_003)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false) 
set_enable_auto_lookat(Actor001, false) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ほう。よくここが分かったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040002")

	change_face(Actor002,"Normal")

	--★★アーサー★★:俺がここをサボりに使っていることは<br>義兄さんも知らないというのに
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:マーリンさんに教えてもらった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040004")

-- ▼直接出力
PlayPartVoice("アーサー", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:マーリンが？<br>そうか…なるほどな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:こんなところでなにしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040006")

	change_face(Actor002,"Normal")

	--★★アーサー★★:仕事の合間の息抜きだよ<br>ここからは、学園や街の様子がよく見えるんでな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ほら、あそこにお前の妹がいるぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？どこだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040009")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:ほら、あそこ<br>療養院で手伝いをしている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:んんん～？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:義姉さんには届かない<br>棚の上のものを取ってくれているな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040013")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:いつも助かってると義姉さんが感謝していたぞ<br>俺からも礼を言わせてくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040014")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:おお！<br>今度はあそこで告白をしている者がいるぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040015")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:どこどこ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040016")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, true) 
set_enable_auto_lookat(Actor001, true) 
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:ほら、あそこだ！上手くいくといいな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:全然見えない…<br>あんた、よく見えるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力

	--★★アーサー★★:実は、視力には自信があってな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_04040021","CO_101015_04040022","CO_101015_04040023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんた、のぞきが趣味なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040025")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:おっと、人聞きが悪いな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040026")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:生徒たちの青春を見守っている<br>と言ってほしい！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040027")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんま変わらないと思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いつも生徒を見守っているんだな<br>さすが学長
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:褒めてくれるのは嬉しいんだが<br>俺にはお前になにもしてやれんぞ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040031")

	change_face(Actor002,"Normal")

	--★★アーサー★★:学長は意外と権限がなくてな<br>許されるなら赤点を握りつぶしてやりたいんだが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040032")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、俺、赤点なの…！？どれが！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040033")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:さてなぁ～？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、今モルガン先生がこっちを見たような
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040036")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:なに！？まさかのぞきがバレたのか！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ぐっ…ノワール<br>お前、割と人が悪いな…！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040039")

	change_face(Actor002,"Smile")

	--★★アーサー★★:だが、そういうの意外と嫌いじゃないぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040040")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:こうして皆が青春を謳歌している様子を<br>眺めているのが俺の幸せでな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040042")


	--★★アーサー★★:折を見てこうやって<br>屋上に来ているというわけだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040044")

	change_face(Actor002,"Smile")

	--★★アーサー★★:若者には青春を謳歌する権利がある<br>もちろん、お前にもだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040045")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:今このときしかない青春！<br>お前もちゃんと楽しむんだぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040046")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…あんたはどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040047")

	change_face(Actor002,"Normal")

	--★★アーサー★★:俺？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:人のことばっか気にして<br>あんたの青春とやらはどうなってるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:もちろん俺にもあったさ<br>もうずいぶん前のことだがな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:夢に溢れ<br>未来への希望を胸に抱いていた――
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040052")


	--★★アーサー★★:あの頃を覚えているからこそ<br>俺はどんな辛い戦いにも身を投じられる
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040053")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:だからこそ言えるんだ<br>青春は謳歌するべきだと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040054")


	--★★アーサー★★:鮮やかな青春の記憶はいつかきっと<br>なによりも強い武器になるから
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040055")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…青春が、武器に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:お前にも、いずれわかるさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040057")


	--★★アーサー★★:…さて、そろそろ戻るか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ああ、そうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:この場所のことは<br>義兄さんには秘密で頼むぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040060")

	change_face(Actor002,"Normal")

	--★★アーサー★★:俺の大事な憩いの場だからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040061")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:だったら、ケイが探さなくて済むように<br>ちゃんと仕事したらいいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04040062")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ハハハ！正論だな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04040063")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
